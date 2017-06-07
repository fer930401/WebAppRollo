﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Rollos.Entidades
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class RollosEntities : DbContext
    {
        public RollosEntities()
            : base("name=RollosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<sp_qrollosxaut_Result> sp_qrollosxaut(string ef_cve, string prg_cve, Nullable<short> sw)
        {
            var ef_cveParameter = ef_cve != null ?
                new ObjectParameter("ef_cve", ef_cve) :
                new ObjectParameter("ef_cve", typeof(string));
    
            var prg_cveParameter = prg_cve != null ?
                new ObjectParameter("prg_cve", prg_cve) :
                new ObjectParameter("prg_cve", typeof(string));
    
            var swParameter = sw.HasValue ?
                new ObjectParameter("sw", sw) :
                new ObjectParameter("sw", typeof(short));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_qrollosxaut_Result>("sp_qrollosxaut", ef_cveParameter, prg_cveParameter, swParameter);
        }
    
        public virtual ObjectResult<sp_WebAppRollos_Result> sp_WebAppRollos(string articulo, string ele_cve, string calidad, Nullable<decimal> ele_exis_um, string uni_uso, Nullable<int> batch, string cliente, Nullable<int> si, Nullable<int> no, Nullable<int> opc)
        {
            var articuloParameter = articulo != null ?
                new ObjectParameter("articulo", articulo) :
                new ObjectParameter("articulo", typeof(string));
    
            var ele_cveParameter = ele_cve != null ?
                new ObjectParameter("ele_cve", ele_cve) :
                new ObjectParameter("ele_cve", typeof(string));
    
            var calidadParameter = calidad != null ?
                new ObjectParameter("calidad", calidad) :
                new ObjectParameter("calidad", typeof(string));
    
            var ele_exis_umParameter = ele_exis_um.HasValue ?
                new ObjectParameter("ele_exis_um", ele_exis_um) :
                new ObjectParameter("ele_exis_um", typeof(decimal));
    
            var uni_usoParameter = uni_uso != null ?
                new ObjectParameter("uni_uso", uni_uso) :
                new ObjectParameter("uni_uso", typeof(string));
    
            var batchParameter = batch.HasValue ?
                new ObjectParameter("batch", batch) :
                new ObjectParameter("batch", typeof(int));
    
            var clienteParameter = cliente != null ?
                new ObjectParameter("cliente", cliente) :
                new ObjectParameter("cliente", typeof(string));
    
            var siParameter = si.HasValue ?
                new ObjectParameter("si", si) :
                new ObjectParameter("si", typeof(int));
    
            var noParameter = no.HasValue ?
                new ObjectParameter("no", no) :
                new ObjectParameter("no", typeof(int));
    
            var opcParameter = opc.HasValue ?
                new ObjectParameter("opc", opc) :
                new ObjectParameter("opc", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_WebAppRollos_Result>("sp_WebAppRollos", articuloParameter, ele_cveParameter, calidadParameter, ele_exis_umParameter, uni_usoParameter, batchParameter, clienteParameter, siParameter, noParameter, opcParameter);
        }
    }
}
