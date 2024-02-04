
using лаба_9_2;

namespace laba9Tests;

[TestClass]
public class UnitTest1
{


    [TestMethod]
    public void TestStudent1()
    {
        Student s1 = new Student();
        Student s2 = new Student("", 0, 0);
        Student s3 = new Student(s1);
        Assert.AreEqual(s1, s2);
    }
    [TestMethod]
    public void TestStudent2()
    {
        Student s2 = new Student("", 0, 0);
        Student s3 = new Student(s2);
        Assert.AreEqual(s2, s3);
    }
    [TestMethod]
    public void TestStudentComparison()
    {
        Student s1 = new Student("a", 1, 1);
        Student s2 = new Student("a", 1, 1);
        string reselt = s1.StudentComparison(s1, s2);
        string expected = "a ровесник a. 1 a равен 1 a";
        Assert.AreEqual(expected, reselt);
    }
    [TestMethod]
    public void TestStudentUpCchar()
    {
        Student s = new Student("a", 1, 1);
        s++;
        Assert.AreEqual(s.GetName(), "A");

    }
    [TestMethod]
    public void TestStudentUnar()
    {
        Student s1 = new Student("", 1, 1);
        s1++;
        Assert.AreEqual(s1.GetAge(), 2);

    }
    [TestMethod]
    public void IntStudent()
    {
        Student s1 = new Student("", 1, 1);
        int res = (int)s1;
        Assert.AreEqual(-1, res);
    }
    [TestMethod]
    public void IntStudent1()
    {
        Student s1 = new Student("", 19, 1);
        int res = (int)s1;
        Assert.AreEqual(2, res);
    }
    [TestMethod]
    public void BoolStudent()
    {
        Student s1 = new Student("", 19, 5);
        bool res = (bool)s1;
        Assert.AreEqual(true, res);
    }
    [TestMethod]
    public void Student1Minus()
    {
        Student s1 = new Student("", 19, 5);
        Student s2 = 1 + s1;
        Student s3 = new Student("", 19, 4);
        Assert.AreEqual(s2, s3);

    }
    [TestMethod]
    public void Student1String()
    {
        Student s1 = new Student("as", 19, 5);
        Student s2 = "ko" + s1;
        Student s3 = new Student("ko", 19, 5);
        Assert.AreEqual(s2, s3);

    }
    [TestMethod]
    public void StudentSet()
    {
        Student s1 = new Student("as", 19, 5);
        Student s2 = new Student();
        s2.SetStudent("as", 19, 5);
        Assert.AreEqual(s1, s2);
    }
    [TestMethod]
    public void StudentCount()
    {
        int m = Student.GetCount();
        int res = 7;
        Assert.AreNotEqual(res, m);
    }
    [TestMethod]
    public void StudentToString()
    {
        Student s1 = new Student("", 19, 5);
        string s = Convert.ToString(s1);
        string res = "True";
        Assert.AreEqual(s, res);
    }
    [TestMethod]
    public void Crg()
    {
        StudentArray a = new StudentArray();
        int m = a.Length;
        Assert.AreEqual(m,0);
    }
    [TestMethod]
    public void Crg1()
    {
        StudentArray ar = new StudentArray();

        StudentArray ar1 = new StudentArray(ar);
       
        Assert.AreNotEqual(ar, ar1);
    }
    [TestMethod]
    public void Crg12()
    {
        StudentArray ar = new StudentArray(3);
        ar[0] = new Student("Gleb", 18, 5);
        ar[1] = new Student("Gleb", 1, 5);
        ar[2] = new Student("Gleb", 20, 5);
        StudentArray ar1 = new StudentArray(ar);
        int index = StudentArray.FindOldestStudent(ar);
        Assert.AreNotEqual(index, 0);
    }
    [TestMethod]
    public void Crg1we()
    {
        StudentArray ar = new StudentArray(1);

        

        Assert.AreNotEqual(ar, 3);
    }
    [TestMethod]
    public void StudentArrCount()
    {
        StudentArray ar = new StudentArray();
        int m = StudentArray.GetCount();
        int res = 0;
        Assert.AreNotEqual(res, m);
    }
}

