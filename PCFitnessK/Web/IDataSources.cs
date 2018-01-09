﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCFitnessK.Web
{
    public interface IDataSource<T>
    {
        Task<List<T>> Load();
        Task<int> Create(T obj);
        Task<T> Read(int key);
        Task Update(int key, T obj);
        Task Delete(int key);
    }
}