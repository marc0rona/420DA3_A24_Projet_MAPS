using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Product
{
	public Product()
	{
		//Strings LIMIT    
        public const Int32 MAX_LENGHT_NAME = 64;
        public const Int32 MAX_LENGHT_DESC = 600;
        public const Int32 MAX_LENGHT_CODEUPC = 6;

        //Fields - Champs 
        public int Id { get; set; }
    }
}
