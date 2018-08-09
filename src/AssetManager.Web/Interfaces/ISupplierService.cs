﻿using AssetManager.Core.Entities;
using AssetManager.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AssetManager.Web
{
    public interface ISupplierViewModelService
    {
        Task AddSupplier(SupplierViewModel supplier, string userId);
        Task<SupplierViewModel> GetSupplier(int id);
        Task DeleteSupplier(int id);
        void UpdateSupplier(SupplierViewModel supplier, string userId);
        IEnumerable<Supplier> GetAllSupplier();
        Task<IEnumerable<Supplier>> GetAllSupplierAsync();
    }
}