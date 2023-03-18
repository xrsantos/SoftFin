﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SoftFin.Web.Classes;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SoftFin.Web.Negocios;
using System.Data.Entity;
using System.Data.Entity.Validation;

namespace SoftFin.Web.Models
{
    public class CategoriaItemProdutoServico
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Descrição"), Required(ErrorMessage = "Campo Descrição obrigatório"), MaxLength(50)]
        public string descricao { get; set; }
        public virtual IEnumerable<ItemProdutoServico> ItemProdutoServico { get; set; }

        public bool Excluir(int id, ref string erro, ParamBase pb)
        {
            try
            {
                int estab = pb.estab_id;
                DbControle db = new DbControle();
                var obj = ObterPorId(id, db, pb);
                if (obj == null)
                {
                    erro = "Registro não encontrado";
                    return false;
                }
                else
                {
                    new LogMudanca().Incluir(obj, "", "",db, pb);
                    db.CategoriaItemProdutoServico.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }

            catch (Exception ex)
            {
                if (ex.InnerException.InnerException.Message.IndexOf("The DELETE statement conflicted with the REFERENCE constraint") > -1)
                {
                    erro = "Registro esta relacionado com outro cadastro";
                    return false;
                }
                else
                {
                    throw ex;
                }
            }
        }

        public bool Alterar(CategoriaItemProdutoServico obj, ParamBase pb)
        {
            DbControle db = new DbControle();

            var objAux = ObterPorId(obj.id, pb);
            if (objAux == null)
                return false;
            else
            {
                new LogMudanca().Incluir(obj, objAux, "",db, pb);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
        }


        private bool validaExistencia(DbControle db, CategoriaItemProdutoServico obj, ParamBase pb)
        {
            int idempresa  = pb.empresa_id;
            if (db.CategoriaItemProdutoServico.Where(x => x.descricao == obj.descricao).Count() != 0)
            {
                return true;
            }

            return (false);
        }

        public bool Incluir(ParamBase pb)
        {
            return Incluir(this, pb);
        }

        public bool Incluir(CategoriaItemProdutoServico obj,ParamBase pb)
        {
            DbControle db = new DbControle();

            if (validaExistencia(db, obj, pb))
                return false;
            else
            {
                new LogMudanca().Incluir(obj, "", "",db, pb);

                db.Set<CategoriaItemProdutoServico>().Add(obj);
                db.SaveChanges();

                return true;
            }
        }


        public CategoriaItemProdutoServico ObterPorId(int id, ParamBase pb)
        {
            return ObterPorId(id, null, pb);
        }

        public CategoriaItemProdutoServico ObterPorId(int id, DbControle db, ParamBase pb)
        {
            int idempresa  = pb.empresa_id;
            if (db == null)
                db = new DbControle();

            return db.CategoriaItemProdutoServico.Where(x => x.id == id ).FirstOrDefault();
        }

        public List<CategoriaItemProdutoServico> ObterTodos(ParamBase pb)
        {
            int idempresa  = pb.empresa_id;
            DbControle db = new DbControle();
            return db.CategoriaItemProdutoServico.ToList();
        }
  

    }
}