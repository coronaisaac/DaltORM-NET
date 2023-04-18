using Dalton.Utility.Global.DaltORM.Class;
using System.Linq.Expressions;

namespace Dalton.Utility.Global.DaltORM.Interfaces
{
  public interface IDatabase
  {
    bool CreateConnection();
    void OpenConnection();
    void CloseConnection();
    bool UseDatabase(string sNameCatalog);
    string StateConnection();
    List<T> ExecuteQuery<T>(string query);
    bool ExecuteQuery(string query);
    void SendTransaction(List<string> querys);
    bool ExistModel<T>();
    bool Create<T>(object oData = null);
    void ForeingKeysInCreate(bool isCreate);
    bool Save<T>(object oData);
    bool Save<T>(ref object oData);
    bool Save<T>(object oData, params Expression<Func<T, object>>[] onlySave);
    bool SaveOrUpdate<T>(ref object oData);
    bool Update<T>(object oData);
    bool Update<T>(object oData, params Expression<Func<T, object>>[] onlySave);
    bool Delete<T>(object oData, int limiteSelect = 0);
    T Reload<T>(object oData);
    bool UseDefaultBD<T>(ref object oData);
    List<T> Get<T>(string Statement1, string Statement2, int level = 0, object oData = null, bool LoadObjAvalible = false, int limiteSelect = 0);
    Where<T> Where<T>(Expression<Func<T, object>> expression, object oData = null, int limiteSelect = 0);
    Where<T> WhereCluster<T>(Expression<Func<T, object>> expression, object oData = null, int limiteSelect = 0);
    void And<T>(Expression<Func<T, object>> expression, ref string Statement1, ref string Statement2);
    void Or<T>(Expression<Func<T, object>> expression, ref string Statement1, ref string Statement2);
    void AndCluster<T>(Expression<Func<T, object>> expression, ref string Statement1, ref string Statement2);
    void OrCluster<T>(Expression<Func<T, object>> expression, ref string Statement1, ref string Statement2);
    void Add<T>(Expression<Func<T, object>> expression, ref string Statement1, ref string Statement2);
    bool GetList<T>(ref object oData, int limitSelect = 0);
    bool VerifyFields<T>();
    bool SynchronizeFields<T>();
    bool Synchronize<T>();
    bool ExecuteStoredProcedure<T>(ref object oData);
    List<Result> ExecuteStoredProcedure<T, Result>(ref object oData);
  }
}
