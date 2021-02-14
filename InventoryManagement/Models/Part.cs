using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace InventoryManagement.Models
{
    public abstract class Part
    {
        #region public properties
        public BindingList<Part> AssociatedParts { get; set; } = new BindingList<Part>();
        public int PartID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        #endregion

        #region public methods
        public void AddAssociatedPart(Part part)
        {
            this.AssociatedParts.Add(part);
        }

        public Part LookupAssociatedPart(int id)
        {
            return this.AssociatedParts.FirstOrDefault(part => part.PartID == id);
        }

        public bool RemoveAssociatedPart(int id)
        {
            var part = this.LookupAssociatedPart(id);
            if (part == null)
            {
                return false;
            }
            return this.AssociatedParts.Remove(part);
        }
        #endregion
    }
}