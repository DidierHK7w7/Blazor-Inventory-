using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
	public class B_Warehouse
	{
		public static List<WarehouseEntity> WarehouseList()
		{
			using (var db = new InventoryContext())
			{
				return db.Warehouses.ToList();
			}
		}
		//crear y guardar info en db
		public static void CreateWarehouse(WarehouseEntity oWarehouse)
		{
			using (var db = new InventoryContext())
			{
				db.Warehouses.Add(oWarehouse);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}

		//actualizar info en db
		public static void UpdateWarehouse(WarehouseEntity oWarehouse)
		{
			using (var db = new InventoryContext())
			{
				db.Warehouses.Update(oWarehouse);   //Se agrega el objeto
				db.SaveChanges();   //Guardar cambios
			}
		}
	}
}
