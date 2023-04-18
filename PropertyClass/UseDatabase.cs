namespace Dalton.Utility.Global.DaltORM.PropertyClass
{
	[AttributeUsage(AttributeTargets.Class)]
  public class UseDatabase : Attribute
  {
	private List<string> _dbnames;

	public List<string> Databases { get => _dbnames; }

	public UseDatabase(params string[] dbname)
	{
	  this._dbnames = dbname.ToList();
	}
  }
}
