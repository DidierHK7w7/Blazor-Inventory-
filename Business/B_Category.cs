using Entities;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class B_Category
	{
		public static List<CategoryEntity> CategoryList()
		{
			using (var db = new InventoryContext())
			{
				return db.Categories.ToList();
			}
		}
		//Actualizar por id
		public static CategoryEntity CategoryById(string id)
		{
			using (var db = new InventoryContext())
			{
				return db.Categories.ToList().LastOrDefault(p => p.CategoryId == id);
			}
		}

		//crear y guardar info en db
		public static void CreateCategory(CategoryEntity oCategory)
		{
			using (var db = new InventoryContext())
			{
				db.Categories.Add(oCategory);	//Se agrega el objeto
				db.SaveChanges();	//Guardar cambios
			}
		}

		//actualizar info en db
		public static void UpdateCategory(CategoryEntity oCategory)
		{
			using (var db = new InventoryContext())
			{
				db.Categories.Update(oCategory);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//eliminar
		public static void DeleteCategory(CategoryEntity oCategory)
		{
			using (var db = new InventoryContext())
			{
				db.Categories.Remove(oCategory);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
