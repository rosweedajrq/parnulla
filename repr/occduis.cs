using System;

public class MyClass {
    public int Value { get; set; }

    public MyClass(int value) {
        this.Value = value;
    }
}

public class Program {
    public static int GetValue(MyClass c) {
        return c.Value;
    }

    public static void Main() {
        MyClass obj = new MyClass(42);
        Console.WriteLine(GetValue(obj));  // Output: 42
    }
}
