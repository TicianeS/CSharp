﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CallPostgre.Model;
using System.Data.Entity;

namespace CallPostgre.DAO
{
    class CargoDAO
    {
        public static bool Incluir(Cargo Cargo)
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;

            try
            {
                db.cargos.Add(Cargo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static bool Alterar(Cargo Cargo)
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.Entry(Cargo).State = EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public static bool Excluir(Cargo Cargo)
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                db.cargos.Remove(Cargo);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static IOrderedEnumerable<Cargo> ListarTodos()
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.cargos.ToList().OrderBy(x => x.nome);
            }
            catch
            {
                return null;
            }
        }

        public static IOrderedEnumerable<Cargo> ObterCargoNome(string nome)
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.cargos.Where(x => x.nome.Contains(nome)).ToList().OrderBy(x => x.nome);
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public static Cargo PesquisarCargo(string nome)
        {
            CallcenterEntities db = SingletonObjectContext.Instance.Context;
            try
            {
                return db.cargos.FirstOrDefault(x => x.nome.Equals(nome));
            }
            catch (Exception e)
            {
                return null;
            }
        }

    }
}
