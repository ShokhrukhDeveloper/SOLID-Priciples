# _---SOLID principles---_

## S-_Single Responsibility Principle (SRP)_


_The Single Responsibility Principle (SRP) is one of the SOLID principles of object-oriented design, which states that a class should have only one reason to change. This principle can be applied at various levels, including classes, methods, and even endpoints._

The Employee class has several reasons to change. The first
reason might be related to the main job of the class: managing
employee data. However, there’s another reason: the format of
the timesheet report may change over time, requiring you to
change the code within the class.
![](/docs/Screenshot.png)

Solve the problem by moving the behavior related to printing
timesheet reports into a separate class. This change lets you
move other report-related stuff to the new class.
![](/docs/Screenshot2.png)



## O-_Open/Close pinciple (OCP)_
_The Open/Closed Principle (OCP) is another fundamental principle of object-oriented design, which states that software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. In other words, you should be able to extend the behavior of a software entity without modifying its source code._

You have an e-commerce application with an Order class that
calculates shipping costs and all shipping methods are hardcoded inside the class. If you need to add a new shipping
method, you have to change the code of the Order class and
risk breaking it.
![](/docs/Screenshot3.png)
You can solve the problem by applying the Strategy pattern. Start
by extracting shipping methods into separate classes with a common interface.
Now when you need to implement a new shipping method, you
can derive a new class from the Shipping interface without
touching any of the Order class’ code. The client code of the
Order class will link orders with a shipping object of the new
class whenever the user selects this shipping methods in the UI.

## L-_Liskov Substitution Principle (LSP)_
_The Liskov Substitution Principle (LSP) is another key principle in object-oriented design, stating that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. In other words, a derived class should be able to substitute its base class without changing the behavior of the program._

Let’s look at an example of a hierarchy of document classes
that violates the substitution principle.
![](/docs/Screenshot5.png)

The save method in the ReadOnlyDocuments subclass throws
an exception if someone tries to call it. The base method
doesn’t have this restriction. This means that the client code
will break if we don’t check the document type before saving it.
The resulting code also violates the open/closed principle,
since the client code becomes dependent on concrete classes of documents. If you introduce a new document subclass,
you’ll need to change the client code to support it.


![](/docs/Screenshot6.png)
You can solve the problem by redesigning the class hierarchy: a subclass should extend the behavior of a superclass,
therefore the read-only document becomes the base class of
the hierarchy. The writable document is now a subclass which
extends the base class and adds the saving behavior.


## I-_Interface Segregation Principle (ISP)_
_The Interface Segregation Principle (ISP) is another SOLID principle of object-oriented design, which states that clients should not be forced to depend on interfaces they do not use. In other words, it suggests that it is better to have many small, specific interfaces than one large, general-purpose interface._

At the time you assumed that all cloud providers have the
same broad spectrum of features as Amazon. But when it
came to implementing support for another provider, it turned
out that most of the interfaces of the library are too wide.
Some methods describe features that other cloud providers
just don’t have.
![](/docs/Screenshot7.png)

While you can still implement these methods and put some
stubs there, it wouldn’t be a pretty solution. The better
62 SOLID Principles / Interface Segregation Principleapproach is to break down the interface into parts. Classes
that are able to implement the original interface can now just
implement several refined interfaces. Other classes can implement only those interfaces which have methods that make
sense for them.

![](/docs/Screenshot8.png)

As with the other principles, you can go too far with this one.
Don’t further divide an interface which is already quite specific. Remember that the more interfaces you create, the more
complex your code becomes. Keep the balance.


## D-_Dependency Inversion Principle (DIP)_
_The Dependency Inversion Principle (DIP) is the last principle of SOLID. It states that high-level modules should not depend on low-level modules; both should depend on abstractions. Additionally, abstractions should not depend on details; details should depend on abstractions._
In simpler terms, this principle suggests that:
1) High-level modules (e.g., classes, components) should not depend on low-level modules. Instead, both should depend on abstractions (interfaces or abstract classes).
2) Abstractions should not depend on implementation details. Instead, implementation details should depend on abstractions.

 _Usually when designing software, you can make a distinction between two levels of classes._

• _Low-level_- classes implement basic operations such as working
with a disk, transferring data over a network, connecting to a
database, etc.

• _High-level_- classes contain complex business logic that directs
low-level classes to do something.

In this example, the high-level budget reporting class uses a
low-level database class for reading and persisting its data.
This means that any change in the low-level class, such as
when a new version of the database server gets released, may
affect the high-level class, which isn’t supposed to care about
the data storage details.

![](/docs/Screenshot9.png)

You can fix this problem by creating a high-level interface
that describes read/write operations and making the reporting class use that interface instead of the low-level class.
Then you can change or extend the original low-level class to
implement the new read/write interface declared by the business logic.

![](/docs/Screenshot10.png)

### As a result, the direction of the original dependency has been inverted: low-level classes are now dependent on high-level abstractions.