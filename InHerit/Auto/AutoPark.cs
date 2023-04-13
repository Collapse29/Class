﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InHerit.Auto
{
    internal class AutoPark                                                                                               // Создали список машин
    {
        private List<AutoBase> _autos;
        public AutoPark()
        {
            _autos = new List<AutoBase>();
        }
        /// <summary>
        /// Создаем метод который ничего не возвращает
        /// </summary>
        public void AddCar(AutoBase newCar)                                            
        {
            if (newCar!=null)
            {
                _autos.Add(newCar);
            }
        }
        
        public void WriteCars()
        {
            foreach (AutoBase currentCar in _autos)
            {
               currentCar.WriteData();
            }
        }

        public void DeletCar(int removeCar)
        {
             if (_autos.Count-1 >= removeCar) 
            {
                _autos.RemoveAt(removeCar);
            }
        }
    }
}
