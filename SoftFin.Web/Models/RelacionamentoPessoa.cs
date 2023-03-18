﻿using Newtonsoft.Json;
using SoftFin.Web.Classes;
using SoftFin.Web.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftFin.Web.Models
{
    public class RelacionamentoPessoa
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "Empresa"), Required(ErrorMessage = "*")]
        public int empresa_id { get; set; }
        [JsonIgnore,ForeignKey("empresa_id")]
        public virtual Empresa Empresa { get; set; }


        [Display(Name = "Pessoa Mestre"), Required(ErrorMessage = "*")]
        public int pessoamestre_id { get; set; }
        [JsonIgnore,ForeignKey("pessoamestre_id")]
        public virtual Pessoa PessoaMestre { get; set; }

        [Display(Name = "Pessoa"), Required(ErrorMessage = "*")]
        public int pessoa_id { get; set; }
        [JsonIgnore,ForeignKey("pessoa_id")]
        public virtual Pessoa Pessoa { get; set; }

        [Display(Name = "Tipo Relacionamento"), Required(ErrorMessage = "*")]
        public int TipoRelacionamento_id { get; set; }
        [JsonIgnore,ForeignKey("TipoRelacionamento_id")]
        public virtual TipoRelacionamento TipoRelacionamento { get; set; }

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
                    db.RelacionamentoPessoa.Remove(obj);
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

        public bool Alterar(RelacionamentoPessoa obj, ParamBase pb)
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


        private bool validaExistencia(DbControle db, RelacionamentoPessoa obj)
        {
            if (obj.pessoa_id == obj.pessoamestre_id)
                return true;

            return (db.RelacionamentoPessoa.Where(p => p.pessoa_id == obj.pessoa_id
                                                && p.pessoamestre_id == obj.pessoamestre_id).Count() >= 1);

        }
        public bool Incluir(ParamBase pb)
        {
            return Incluir(this, pb);
        }
        public bool Incluir(RelacionamentoPessoa obj, ParamBase pb)
        {
            DbControle db = new DbControle();

            if (validaExistencia(db, obj))
                return false;
            else
            {
                new LogMudanca().Incluir(obj, "", "",db, pb);

                db.Set<RelacionamentoPessoa>().Add(obj);
                db.SaveChanges();

                return true;
            }
        }


        public RelacionamentoPessoa ObterPorId(int id, ParamBase pb)
        {
            return ObterPorId(id, null, pb);
        }
        public RelacionamentoPessoa ObterPorId(int id, DbControle db, ParamBase pb)
        {
            int idempresa  = pb.empresa_id;
            if (db == null)
                db = new DbControle();

            return db.RelacionamentoPessoa.Where(x => x.id == id && x.empresa_id == idempresa).FirstOrDefault();
        }
        public List<RelacionamentoPessoa> ObterTodos(ParamBase pb)
        {
            int idempresa  = pb.empresa_id;
            DbControle db = new DbControle();
            return db.RelacionamentoPessoa.Where(x => x.empresa_id == idempresa).ToList();
        }
    }
}
