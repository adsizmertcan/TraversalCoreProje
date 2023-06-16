﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract.AbstractUOW
{
    public interface IGenericUOWService<T>
    {
        void Insert(T t);
        void Update(T t);
        void MultiUpdate(List<T> t);
        T GetByID(int id);
    }
}
