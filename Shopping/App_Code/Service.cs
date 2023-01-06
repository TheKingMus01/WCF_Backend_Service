using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class Service : IService
{
    public void CreateNewStudent(students std)
    {
		db0Entities1 entities1 = new db0Entities1();
        entities1.students.Add(std);
        entities1.SaveChanges();

	}

    public void DeleteStudent(students std)
    {
        db0Entities1 entities1 = new db0Entities1();
        entities1.students.Remove(std);
        entities1.SaveChanges();
    }

    public void DeleteWithId(int id)
    {
        db0Entities1 entities1 = new db0Entities1();

        students std = entities1.students.Where(e => e.Idstd == id).First();
        entities1.students.Remove(std);
        entities1.SaveChanges();
    }

    public students GetStudentById(int id)
    {
        db0Entities1 entities1 = new db0Entities1();
        students etudiant = entities1.students.Where(e => e.Idstd == id).First();
        return etudiant;
    }

    public List<students> GetStudents()
	{
        db0Entities1 entities1= new db0Entities1();
		List<students> lst = entities1.students.ToList();
		//lst.Where(e=>e.Idstd==1).ToList();	
        return entities1.students.ToList();
	}

    public void UpdateStudent(students std)
    {
        db0Entities1 entities1 = new db0Entities1();
        entities1.students.AddOrUpdate(std);
        entities1.SaveChanges();
    }
}
