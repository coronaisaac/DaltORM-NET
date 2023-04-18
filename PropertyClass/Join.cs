namespace Dalton.Utility.Global.DaltORM.PropertyClass
{
    [AttributeUsage(AttributeTargets.Property)]
  public class Join : Attribute
  {
    string TableName;
    string ColumnID;

    public Join(string TableName, string ColumnID)
    {
      this.TableName = TableName;
      this.ColumnID = ColumnID;
    }
  }
}
