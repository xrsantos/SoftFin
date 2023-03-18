﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity;
using SoftFin.Web.Classes;
using SoftFin.Web.Models;
using System.ComponentModel.DataAnnotations.Schema;
using SoftFin.Web.Negocios;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace SoftFin.Web.Models
{
    public class TipoDespesa
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Empresa"), Required(ErrorMessage = "*")]
        public int empresa_id { get; set; }
        [JsonIgnore,ForeignKey("empresa_id")]
        public virtual Empresa Empresa { get; set; }

        [Display(Name = "Descrição"),
        Required(ErrorMessage = "*"), MaxLength(30)]
        public string descricao { get; set; }

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
                    db.TipoDespesa.Remove(obj);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.IndexOf("FK") > 0)
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

        public bool Alterar(TipoDespesa obj, ParamBase pb)
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


        private bool validaExistencia(DbControle db, TipoDespesa obj)
        {
            return (false);
        }
        public bool Incluir(ParamBase pb)
        {
            return Incluir(this, pb);
        }
        public bool Incluir(TipoDespesa obj, ParamBase pb)
        {
            DbControle db = new DbControle();

            if (validaExistencia(db, obj))
                return false;
            else
            {
                new LogMudanca().Incluir(obj, "", "",db, pb);

                db.Set<TipoDespesa>().Add(obj);
                db.SaveChanges();

                return true;
            }
        }


        public TipoDespesa ObterPorId(int id, ParamBase pb)
        {
            return ObterPorId(id, null, pb);
        }
        public TipoDespesa ObterPorId(int id, DbControle db, ParamBase pb)
        {
            int empresa  = pb.empresa_id;
            if (db == null)
                db = new DbControle();

            return db.TipoDespesa.Where(x => x.id == id && x.empresa_id == empresa).FirstOrDefault();
        }
        public List<TipoDespesa> ObterTodos(ParamBase pb)
        {
            int empresa  = pb.empresa_id;
            DbControle db = new DbControle();
            var objs = db.TipoDespesa.Where(x => x.empresa_id == empresa).ToList();

            if (objs.Count() == 0)
            {
                ConfiguraZero(db);
                objs = db.TipoDespesa.Where(x => x.empresa_id == empresa).ToList();
            }
            return objs;

        }

        public SelectList CarregaTipo(ParamBase pb)
        {
            var con1 = ObterTodos(pb);
            var items = new List<SelectListItem>();
            foreach (var item in con1)
            {
                items.Add(new SelectListItem() { Value = item.id.ToString(), Text = String.Format("{0}", item.descricao) });
            }
            var listret = new SelectList(items, "Value", "Text");
            return listret;
        }

        private void ConfiguraZero(DbControle db)
        {
            //var obj = new TipoDespesa()
            //{
            //    descricao = "Estacionamento",
            //    empresa_id = Acesso.EmpresaLogado()
            //};
            //obj.Incluir();

            //obj = new TipoDespesa()
            //{
            //    descricao = "Taxi",
            //    empresa_id = Acesso.EmpresaLogado()
            //};
            //obj.Incluir();

            //obj = new TipoDespesa();
            //obj.descricao = "Refeição";
            //obj.empresa_id  = pb.empresa_id;
            //obj.Incluir();

            //obj = new TipoDespesa();
            //obj.descricao = "Estadia";
            //obj.empresa_id  = pb.empresa_id;
            //obj.Incluir();

            //obj = new TipoDespesa();
            //obj.descricao = "Outros";
            //obj.empresa_id  = pb.empresa_id;
            //obj.Incluir();

        }


    }
}