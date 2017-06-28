﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Data.Entity
Imports System.Data.Entity.Infrastructure
Imports System.Data.Entity.Core.Objects
Imports System.Linq

Partial Public Class RecordEntities
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=RecordEntities")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As DbModelBuilder)
        Throw New UnintentionalCodeFirstException()
    End Sub


    Public Overridable Function spD_FaseRecupera(id_Fase As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim id_FaseParameter As ObjectParameter = If(id_Fase.HasValue, New ObjectParameter("id_Fase", id_Fase), New ObjectParameter("id_Fase", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spD_FaseRecupera", id_FaseParameter)
    End Function

    Public Overridable Function spI_FaseRecupera(strFase As String) As ObjectResult(Of Nullable(Of Integer))
        Dim strFaseParameter As ObjectParameter = If(strFase IsNot Nothing, New ObjectParameter("strFase", strFase), New ObjectParameter("strFase", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spI_FaseRecupera", strFaseParameter)
    End Function

    Public Overridable Function spU_FaseRecupera(id_Fase As Nullable(Of Integer), strFase As String) As ObjectResult(Of Nullable(Of Integer))
        Dim id_FaseParameter As ObjectParameter = If(id_Fase.HasValue, New ObjectParameter("id_Fase", id_Fase), New ObjectParameter("id_Fase", GetType(Integer)))

        Dim strFaseParameter As ObjectParameter = If(strFase IsNot Nothing, New ObjectParameter("strFase", strFase), New ObjectParameter("strFase", GetType(String)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spU_FaseRecupera", id_FaseParameter, strFaseParameter)
    End Function

    Public Overridable Function spd_estatus_stro(id_estatus As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim id_estatusParameter As ObjectParameter = If(id_estatus.HasValue, New ObjectParameter("id_estatus", id_estatus), New ObjectParameter("id_estatus", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spd_estatus_stro", id_estatusParameter)
    End Function

    Public Overridable Function spi_Estatus_Stro(estatus As String, id_fase As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim estatusParameter As ObjectParameter = If(estatus IsNot Nothing, New ObjectParameter("estatus", estatus), New ObjectParameter("estatus", GetType(String)))

        Dim id_faseParameter As ObjectParameter = If(id_fase.HasValue, New ObjectParameter("id_fase", id_fase), New ObjectParameter("id_fase", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spi_Estatus_Stro", estatusParameter, id_faseParameter)
    End Function

    Public Overridable Function spu_estatus_stro(id_estatus As Nullable(Of Integer), estatus As String, id_fase As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim id_estatusParameter As ObjectParameter = If(id_estatus.HasValue, New ObjectParameter("id_estatus", id_estatus), New ObjectParameter("id_estatus", GetType(Integer)))

        Dim estatusParameter As ObjectParameter = If(estatus IsNot Nothing, New ObjectParameter("estatus", estatus), New ObjectParameter("estatus", GetType(String)))

        Dim id_faseParameter As ObjectParameter = If(id_fase.HasValue, New ObjectParameter("id_fase", id_fase), New ObjectParameter("id_fase", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spu_estatus_stro", id_estatusParameter, estatusParameter, id_faseParameter)
    End Function

    Public Overridable Function spd_nivel_aviso(id_nivel As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim id_nivelParameter As ObjectParameter = If(id_nivel.HasValue, New ObjectParameter("id_nivel", id_nivel), New ObjectParameter("id_nivel", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spd_nivel_aviso", id_nivelParameter)
    End Function

    Public Overridable Function spi_Nivel_Aviso(desc_nivel As String, d_tolera As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim desc_nivelParameter As ObjectParameter = If(desc_nivel IsNot Nothing, New ObjectParameter("desc_nivel", desc_nivel), New ObjectParameter("desc_nivel", GetType(String)))

        Dim d_toleraParameter As ObjectParameter = If(d_tolera.HasValue, New ObjectParameter("d_tolera", d_tolera), New ObjectParameter("d_tolera", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spi_Nivel_Aviso", desc_nivelParameter, d_toleraParameter)
    End Function

    Public Overridable Function spu_nivel_aviso(id_nivel As Nullable(Of Integer), desc_nivel As String, d_tolera As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim id_nivelParameter As ObjectParameter = If(id_nivel.HasValue, New ObjectParameter("id_nivel", id_nivel), New ObjectParameter("id_nivel", GetType(Integer)))

        Dim desc_nivelParameter As ObjectParameter = If(desc_nivel IsNot Nothing, New ObjectParameter("desc_nivel", desc_nivel), New ObjectParameter("desc_nivel", GetType(String)))

        Dim d_toleraParameter As ObjectParameter = If(d_tolera.HasValue, New ObjectParameter("d_tolera", d_tolera), New ObjectParameter("d_tolera", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spu_nivel_aviso", id_nivelParameter, desc_nivelParameter, d_toleraParameter)
    End Function

    Public Overridable Function spd_taviso_Usuario(idav As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim idavParameter As ObjectParameter = If(idav.HasValue, New ObjectParameter("idav", idav), New ObjectParameter("idav", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spd_taviso_Usuario", idavParameter)
    End Function

    Public Overridable Function spi_taviso_Usuario(cod_usuario As String, cod_sector As Nullable(Of Decimal), id_nivel As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Dim cod_sectorParameter As ObjectParameter = If(cod_sector.HasValue, New ObjectParameter("cod_sector", cod_sector), New ObjectParameter("cod_sector", GetType(Decimal)))

        Dim id_nivelParameter As ObjectParameter = If(id_nivel.HasValue, New ObjectParameter("id_nivel", id_nivel), New ObjectParameter("id_nivel", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spi_taviso_Usuario", cod_usuarioParameter, cod_sectorParameter, id_nivelParameter)
    End Function

    Public Overridable Function spu_taviso_Usuario(cod_usuario As String, cod_sector As Nullable(Of Decimal), idav As Nullable(Of Integer), nivel As Nullable(Of Integer)) As ObjectResult(Of Nullable(Of Integer))
        Dim cod_usuarioParameter As ObjectParameter = If(cod_usuario IsNot Nothing, New ObjectParameter("cod_usuario", cod_usuario), New ObjectParameter("cod_usuario", GetType(String)))

        Dim cod_sectorParameter As ObjectParameter = If(cod_sector.HasValue, New ObjectParameter("cod_sector", cod_sector), New ObjectParameter("cod_sector", GetType(Decimal)))

        Dim idavParameter As ObjectParameter = If(idav.HasValue, New ObjectParameter("idav", idav), New ObjectParameter("idav", GetType(Integer)))

        Dim nivelParameter As ObjectParameter = If(nivel.HasValue, New ObjectParameter("nivel", nivel), New ObjectParameter("nivel", GetType(Integer)))

        Return DirectCast(Me, IObjectContextAdapter).ObjectContext.ExecuteFunction(Of Nullable(Of Integer))("spu_taviso_Usuario", cod_usuarioParameter, cod_sectorParameter, idavParameter, nivelParameter)
    End Function

End Class
