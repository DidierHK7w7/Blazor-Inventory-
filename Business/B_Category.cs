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
		public List<CategoryEntity> CategoryList()
		{
			using (var db = new InventoryContext())
			{
				return db.Categories.ToList();
			}
		}
		//crear y guardar info en db
		public void CreateCategory(CategoryEntity oCategory)
		{
			using (var db = new InventoryContext())
			{
				db.Categories.Add(oCategory);	//Se agrega el objeto
				db.SaveChanges();	//Guardar cambios
			}
		}

		//actualizar info en db
		public void UpdateCategory(CategoryEntity oCategory)
		{
			using (var db = new InventoryContext())
			{
				db.Categories.Update(oCategory);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
