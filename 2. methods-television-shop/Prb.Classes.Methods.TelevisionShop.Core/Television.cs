using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prb.Classes.Methods.TelevisionShop.Core
{
    public class Television
    {
        private string brand;
        private int diagonal;
        private char energyLabel;

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }

        public string GetBrand()
        {
            return brand;
        }

        public void SetDiagonal(int diagonal)
        {
            this.diagonal = diagonal;
        }

        public int GetDiagonal() 
        {
            return diagonal;
        }

        public void SetEnergyLabel(char energyLabel)
        {
            this.energyLabel = energyLabel;
        }

        public char GetEnergyLabel() 
        {
            return energyLabel;
        }

        public Television(string brand, int diagonal, char energyLabel) 
        {
            SetBrand(brand);
            SetDiagonal(diagonal);
            SetEnergyLabel(energyLabel);
        }


        public override string ToString()
        {
            return $"{brand}: {diagonal}\" - {energyLabel}";
        }
    }
}
