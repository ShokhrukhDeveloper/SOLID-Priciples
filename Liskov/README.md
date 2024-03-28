# Liskov subsitution priciples
When extending a class, remember that you should be
able to pass objects of the subclass in place of objects of
the parent class without breaking the client code.
### Document class
![](/Liskov/docs/document.png)
### ReadOnlyDocument class
![](/Liskov/docs/document=readonly.png)

Let’s look at an example of a hierarchy of document classes
that violates the substitution principle.
### Oveview
![](/docs/Screenshot5.png)
The save method in the ReadOnlyDocuments subclass throws
an exception if someone tries to call it. The base method
doesn’t have this restriction. This means that the client code
will break if we don’t check the document type before saving it.

### Oveview
![](/docs/Screenshot6.png)

 ### WritableDocument class
![](/Liskov/docs/documentwribale.png)

 ### Project class
![](/Liskov/docs/projrect.png)