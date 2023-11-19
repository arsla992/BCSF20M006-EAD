using System;
namespace SingletonDesignPattren
{
    //Example 1: Eager Initialization
    public class DBConnection
    {
        private static DBConnection _db=new DBConnection();
        private DBConnection()
        {

        }
        public static DBConnection GetConnection() 
        {
            return _db;
        }
    }
    //Example 2: Lazy Initialization
    public class LazyDBConnection
    {
        private static LazyDBConnection _db; // I am not Intializing at run time

        private LazyDBConnection() 
        {

        }

        public static LazyDBConnection GetConnection() 
        {
            if(_db == null)
            {
                _db = new LazyDBConnection();
            }
            return _db;
        }
    }

    public class Driver
    {
        public static void Main(string[] args)
        {
            /*DBConnection conn = new DBConnection();*/ // it creates an error as i have set it as private
            // Now I can call the get connection method which is set as public.
            // By setting private, we Restrict only one Object is created.

            DBConnection conn=DBConnection.GetConnection();

            // Similarly, for the Example 2: Lazy Initialization
            /*LazyDBConnection conn2 = new LazyDBConnection(); *///Due to Protection level, we cannot create a instance

            LazyDBConnection conn2 = LazyDBConnection.GetConnection();
        }
    }

}
