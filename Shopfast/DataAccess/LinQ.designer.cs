﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Shopfast.DataAccess
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Shopfast")]
	public partial class LinQDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public LinQDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}


        public LinQDataContext()
    : this(@"Data Source=localhost;Initial Catalog=Shopfast;Integrated Security=True;Encrypt=False")
        {
        }

        public LinQDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public LinQDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.savaCustomer")]
		public int savaCustomer([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(50)")] string lastname, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string password, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(100)")] string email, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(20)")] string phone, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] string address, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] ref System.Nullable<int> result, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="NVarChar(255)")] ref string message)
		{
			IExecuteResult result1 = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), name, lastname, password, email, phone, address, result, message);
			result = ((System.Nullable<int>)(result1.GetParameterValue(6)));
			message = ((string)(result1.GetParameterValue(7)));
			return ((int)(result1.ReturnValue));
		}
	}
}
#pragma warning restore 1591
