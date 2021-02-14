using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public class Product
    {
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        #region public methods
        public void AddAssociatedPart(Part part)
        {
            if (LookupAssociatedPart(part.PartID) != null) return; // don't add dups
            AssociatedParts.Add(part);
        }

        public Part LookupAssociatedPart(int id)
        {
            return AssociatedParts.FirstOrDefault(part => part.PartID == id);
        }

        public bool RemoveAssociatedPart(int id)
        {
            var part = LookupAssociatedPart(id);
            if (part == null)
            {
                return false;
            }
            return AssociatedParts.Remove(part);
        }
        #endregion
    }
}