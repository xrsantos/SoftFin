﻿using Newtonsoft.Json;
using SoftFin.Web.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoftFin.Web.Models
{
    public class LojaCaixa: BaseModels
    {
        public int id { get; set; }

        [Required(ErrorMessage = "Informe o código da Caixa"), MaxLength(25)]
        public string codigo { get; set; }

        [Required(ErrorMessage = "Informe a descrição da caixa"), MaxLength(50)]
        public string descricao { get; set; }

        [Required(ErrorMessage = "ativo")]
        public bool ativo { get; set; }

        public int Loja_id { get; set; }

        [JsonIgnore,ForeignKey("Loja_id")]
        public virtual Loja Loja { get; set; }


        private bool validaExistencia(DbControle db, LojaCaixa obj)
        {
            return (false);
        }
        public bool Incluir(ParamBase paramBase)
        {
            return Incluir(this, paramBase);
        }
        public bool Incluir(LojaCaixa obj, ParamBase paramBase)
        {
            DbControle db = new DbControle();

            if (validaExistencia(db, obj))
                return false;
            else
            {
                new LogMudanca().Incluir(obj, "", "",null,paramBase);

                db.Set<LojaCaixa>().Add(obj);
                db.SaveChanges();

                return true;
            }
        }


        public bool Alterar(ParamBase paramBase)
        {
            return Alterar(this, paramBase);
        }
        public bool Alterar(LojaCaixa obj, ParamBase paramBase)
        {
            DbControle db = new DbControle();

            var objAux = ObterPorId(obj.id, paramBase);
            if (objAux == null)
                return false;
            else
            {
                new LogMudanca().Incluir(obj, objAux, "", null, paramBase);
                db.Entry(obj).State = EntityState.Modified;
                db.SaveChanges();

                return true;
            }
        }

        public bool Excluir(ref string erro, ParamBase paramBase)
        {
            return Excluir(this.id, ref erro, paramBase);
        }
        public bool Excluir(int id, ref string erro, ParamBase paramBase)
        {
            try
            {
                DbControle db = new DbControle();
                var obj = ObterPorId(id, db, paramBase);
                if (obj == null)
                {
                    erro = "Registro não encontrado";
                    return false;
                }
                else
                {
                    new LogMudanca().Incluir(obj, "", "", db, paramBase);
                    db.LojaCaixa.Remove(obj);
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


        public LojaCaixa ObterPorId(int id, ParamBase paramBase)
        {
            return ObterPorId(id, null, paramBase);
        }
        public LojaCaixa ObterPorId(int id, DbControle banco, ParamBase paramBase)
        {
            int idestab = paramBase.estab_id;
            if (banco == null)
                banco = new DbControle();

            return banco.LojaCaixa.Where(x => x.id == id && x.Loja.estabelecimento_id == idestab).FirstOrDefault();
        }

        public List<LojaCaixa> ObterTodos(ParamBase paramBase)
        {
            int idestab = paramBase.estab_id;
            var banco = new DbControle();

            return banco.LojaCaixa.Where(x => x.Loja.estabelecimento_id == idestab).ToList();
        }
        public List<LojaCaixa> ObterTodosPorLoja(int idLoja, ParamBase paramBase)
        {
            int idestab = paramBase.estab_id;
            var banco = new DbControle();

            return banco.LojaCaixa.Where(x => x.Loja.estabelecimento_id == idestab && x.Loja_id == idLoja ).ToList();
        }
    }
}