using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class B_Product
	{
		public List<ProductEntity> ProductList()
		{
			using (var db = new InventoryContext())
			{
				return db.Products.ToList();
			}
		}
		//crear y guardar info en db
		public void CreateProduct(ProductEntity oProduct)
		{
			using (var db = new InventoryContext())
			{
				db.Products.Add(oProduct);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//actualizar info en db
		public void UpdateProduct(ProductEntity oProduct)
		{
			using (var db = new InventoryContext())
			{
				db.Products.Update(oProduct);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
