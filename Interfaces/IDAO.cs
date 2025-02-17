﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_Sistelie.Interfaces
{
    /// <summary>
    ///     Interface (contrato) das classes DAO 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    interface IDAO<T>
    {
        void Insert(T t);

        void Update(T t);

        void Delete(T t);

        List<T> List();

        T GetById(int id);
    }
}
