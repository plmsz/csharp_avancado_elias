 String.Concat has many versions. Rest the mouse pointer on Concat in the following statement to verify that the version that is used here takes three object arguments. Both 42 and true must be boxed.

```C#
Console.WriteLine(String.Concat("Answer", 42, true));


int i = 123;
// The following line boxes i.
object o = i;


o = 123;
i = (int)o;  // unboxing

``