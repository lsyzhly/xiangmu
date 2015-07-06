using System;
using System.Data;
using System.Data.Common;
using System.IO;
using System.Data.SQLite;

abstract class Person
{
    string m_name;
    string m_id;
    string m_password;

    protected Person(string name,string id,string password)
    {
        m_name=name;
        m_id=id;
        m_password=password;
    }
	public virtual string name
	{
		get {return m_name;}
		set {m_name=value;}
	}
	public virtual string password
	{
		get {return m_password;}
		set {m_password=value;}
	}
	public virtual string id
	{
		get {return m_id;}
	}
}

class Student: Person
{
    public Student(string name,string id,string password):base(name,id,password) {}
/* 	public ChoseCourse(){
		
	} */
}


class Teacher: Person
{
    public Teacher(string name,string id,string password):base(name,id,password) {}
	public void AddGrade(string student_id,string course_id,int grade)
	{
		//App.cmd.CommandText=String.Format(@"insert into value ('{0}','{1}',{2})",student_id,course_id,grade);
	}
}


class Administrator: Person
{
    public Administrator(string name,string id,string password):base(name,id,password) {}
	public void addStudent(string name,string id,string password)
	{
		cmd.CommandText=String.Format(@"insert into person values('{0},{1},{2},{3}')",id,name,password,2);
		cmd.ExecuteNonQuery();
	}
	public void addTeacher(string name,string id,string password)
	{
		cmd.CommandText=String.Format(@"insert into person values('{0},{1},{2},{3}')",id,name,password,1);
		cmd.ExecuteNonQuery();
	}
	public void addAdministrator(string name,string id,string password)
	{
		cmd.CommandText=String.Format(@"insert into person values('{0},{1},{2},{3}')",id,name,password,0);
		cmd.ExecuteNonQuery();
	}
	//public void 
}


class Course
{
    string m_course_name;
    string m_teacher_id;
    string m_course_id;
}


class OnCourse
{
    string m_student_id;
    string m_course_id;
    int m_grade;
}

class App
{
    static DbConnection connection;
	public static DbCommand cmd;
    public static Person login (string id, string password)
    {
        Person p;
        cmd.CommandText=@"select name,password,type from person where id="+@"'"+id+@"';";
        DbDataReader data=cmd.ExecuteReader();
        if (data.Read())
        {
            string r_name=data.GetString(0);
            string r_password=data.GetString(1);
            int type=data.GetInt32(2);
            if (password==r_password)
            {
                switch (type)
                {
                case 0:
                    p=new Administrator(id,r_name,password);
                    break;
                case 1:
                    p=new Teacher(id,r_name,password);
                    break;
                case 2:
                    p=new Student(id,r_name,password);
                    break;
                default:
                    System.Console.WriteLine("wrong!!");
                    return null;
                }
                return p;
            }
			else
				return null;
        }
        return null;
    }
    public static void init (string path)
    {
        bool flag = true;
        if (File. Exists(path))
        {
            flag = false;
        }
        SQLiteConnection con = new SQLiteConnection ("Data Source="+path);
		connection=con;
        con.Open();
		cmd=new SQLiteCommand(con);
        if (flag)
        {
            cmd.CommandText ="create table person (id char(10),name char(10),password char(20),type int);"+
                           "create table course (id char(10),name char(20),t_id char(10));" +
                           "create table OnCourse (s_id char(10),c_id char(10),int grade);" +
						   "create table Acourse (name char(20),t_id char(10))"+
                           "insert into person values('test','test','test',0);";
            cmd.ExecuteNonQuery();
        }
    }
    static void Main()
    {
        init ("D:\\asd.db");
        Person a=login("test","test");
		Console.WriteLine(a.GetType());
        connection.Close();
    }
}
