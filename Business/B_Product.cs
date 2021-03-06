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
		public static List<ProductEntity> ProductList()
		{
			using (var db = new InventoryContext())
			{
				return db.Products.ToList();
			}
		}

		//enviar datos al form de actualizacion
		public static ProductEntity ProductById(string id)
		{
			using (var db = new InventoryContext())
			{
				return db.Products.ToList().LastOrDefault(p => p.ProductId == id);
			}
		}

		//crear y guardar info en db
		public static void CreateProduct(ProductEntity oProduct)
		{
			using (var db = new InventoryContext())
			{
				db.Products.Add(oProduct);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//actualizar info en db
		public static void UpdateProduct(ProductEntity oProduct)
		{
			using (var db = new InventoryContext())
			{
				db.Products.Update(oProduct);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//eliminar
		public static void DeleteProduct(ProductEntity oProduct)
        {
			using (var db = new InventoryContext())
			{
				db.Products.Remove(oProduct);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
