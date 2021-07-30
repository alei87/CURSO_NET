﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LISTADO_ALUMNO
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ALUMNOS_SQL")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Definiciones de métodos de extensibilidad
    partial void OnCreated();
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::LISTADO_ALUMNO.Properties.Settings.Default.ALUMNOS_SQLConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spCargarGrid_Alumnos")]
		public ISingleResult<spCargarGrid_AlumnosResult> spCargarGrid_Alumnos()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<spCargarGrid_AlumnosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spBusquedaCodigo_Alumnos")]
		public ISingleResult<spBusquedaCodigo_AlumnosResult> spBusquedaCodigo_Alumnos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="Código", DbType="Int")] System.Nullable<int> código)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), código);
			return ((ISingleResult<spBusquedaCodigo_AlumnosResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.spBusqueda_DNI_Alumnos")]
		public ISingleResult<spBusqueda_DNI_AlumnosResult> spBusqueda_DNI_Alumnos([global::System.Data.Linq.Mapping.ParameterAttribute(Name="DNI", DbType="NVarChar(10)")] string dNI)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), dNI);
			return ((ISingleResult<spBusqueda_DNI_AlumnosResult>)(result.ReturnValue));
		}
	}
	
	public partial class spCargarGrid_AlumnosResult
	{
		
		private int _Código;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public spCargarGrid_AlumnosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Código", DbType="Int NOT NULL")]
		public int Código
		{
			get
			{
				return this._Código;
			}
			set
			{
				if ((this._Código != value))
				{
					this._Código = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class spBusquedaCodigo_AlumnosResult
	{
		
		private int _Código;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public spBusquedaCodigo_AlumnosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Código", DbType="Int NOT NULL")]
		public int Código
		{
			get
			{
				return this._Código;
			}
			set
			{
				if ((this._Código != value))
				{
					this._Código = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
	
	public partial class spBusqueda_DNI_AlumnosResult
	{
		
		private int _Código;
		
		private string _Nombre;
		
		private string _DNI;
		
		private string _Turno;
		
		private string _Sexo;
		
		private System.Nullable<bool> _Repetidor;
		
		private string _Modulo;
		
		private string _Especialidad;
		
		public spBusqueda_DNI_AlumnosResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Código", DbType="Int NOT NULL")]
		public int Código
		{
			get
			{
				return this._Código;
			}
			set
			{
				if ((this._Código != value))
				{
					this._Código = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Nombre", DbType="NVarChar(30)")]
		public string Nombre
		{
			get
			{
				return this._Nombre;
			}
			set
			{
				if ((this._Nombre != value))
				{
					this._Nombre = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DNI", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string DNI
		{
			get
			{
				return this._DNI;
			}
			set
			{
				if ((this._DNI != value))
				{
					this._DNI = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Turno", DbType="NVarChar(10)")]
		public string Turno
		{
			get
			{
				return this._Turno;
			}
			set
			{
				if ((this._Turno != value))
				{
					this._Turno = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sexo", DbType="NVarChar(10)")]
		public string Sexo
		{
			get
			{
				return this._Sexo;
			}
			set
			{
				if ((this._Sexo != value))
				{
					this._Sexo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Repetidor", DbType="Bit")]
		public System.Nullable<bool> Repetidor
		{
			get
			{
				return this._Repetidor;
			}
			set
			{
				if ((this._Repetidor != value))
				{
					this._Repetidor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Modulo", DbType="NVarChar(10) NOT NULL", CanBeNull=false)]
		public string Modulo
		{
			get
			{
				return this._Modulo;
			}
			set
			{
				if ((this._Modulo != value))
				{
					this._Modulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Especialidad", DbType="NVarChar(25)")]
		public string Especialidad
		{
			get
			{
				return this._Especialidad;
			}
			set
			{
				if ((this._Especialidad != value))
				{
					this._Especialidad = value;
				}
			}
		}
	}
}
#pragma warning restore 1591