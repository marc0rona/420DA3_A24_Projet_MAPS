using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ExtraAdvancedMultiTier.DataAccess.Abstractions;
public abstract class AbstractDbContext : DbContext {

    protected AbstractDbContext() : base() { }

    public AbstractDbContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// Méthode générique permettant d'obtenir le <see cref="DbSet{TEntity}"/> d'une entité
    /// spécifique défini dans une classe de contexte concrète.<br/>
    /// Retourne le <see cref="DbSet{TEntity}"/> pour l'entité dont la classe est passée
    /// en paramètre dans <typeparamref name="DtoType"/>.
    /// </summary>
    /// <remarks>
    /// Cette méthode au code assez compliqué est nécessaire pour généraliser dans 
    /// <see cref="AbstractDao{EntityType, EntityIdType}"/> les méthodes d'opérations
    /// de base des DAOs. Elle utilise la fonctionnalité de réflection pour analyser la classe 
    /// de contexte concrète qui hérite de <see cref="AbstractDbContext"/>, obtenir la liste 
    /// de ses <see cref="PropertyInfo">propriétés</see>, comparer le type des propriétés avec 
    /// celui passé à <typeparamref name="DtoType"/> et retourner la valeur de la propriété 
    /// dont les types correspondent.
    /// </remarks>
    /// <typeparam name="DtoType">La classe de l'entité dont on veut obtenir le DbSet.</typeparam>
    /// <returns>Le DbSet pour le type d'entité reçu.</returns>
    public virtual DbSet<DtoType> GetDbSet<DtoType>() where DtoType : class {
        IEnumerable<PropertyInfo> contextProperties = this.GetType().GetProperties();
        List<PropertyInfo> matchingProps = new List<PropertyInfo>();
        foreach (PropertyInfo property in contextProperties) {
            if (property.PropertyType == typeof(DbSet<DtoType>)) {
                matchingProps.Add(property);
            }
        }
        try {
            DbSet<DtoType> property = (DbSet<DtoType>?) matchingProps.Single().GetValue(this)
                ?? throw new Exception($"La propriété de type DbSet<{typeof(DtoType).Name}> dans la classe contexte n'est pas initialisée (elle est vide).");
            return property;
        } catch (InvalidOperationException ioex) {
            throw new Exception($"Il n'y a pas de propriété de type DbSet<{typeof(DtoType).Name}> définie dans la classe contexte.", ioex);
        }
    }

}
