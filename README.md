# Functional Dependencies

A functional dependency (FD) is a relationship between two attributes, typically between the PK and other non-key attributes within a table. For any relation R, attribute Y is functionally dependent on attribute X (usually the PK), if for every valid instance of X, that value of X uniquely determines the value of Y. This relationship is indicated by the representation below:
        
        X-->Y

For examples:
        **StudentID-->StudentName**
        **ISBN-->Title**

## Inference Rules
Armstrong’s axioms are a set of inference rules used to infer all the functional dependencies on a relational database. They were developed by William W. Armstrong. The following describes what will be used, in terms of notation, to explain these axioms.

Let R(U) be a relation scheme over the set of attributes U. We will use the letters X, Y, Z to represent any subset of and, for short, the union of two sets of attributes, instead of the usual  X U Y.

### Axiom of reflexivity
This axiom says, if Y is a subset of X, then X determines Y
    
    if Y⊆X so X-->Y
    
###Axiom of augmentation
The axiom of augmentation, also known as a partial dependency, says if X determines Y, then XW determines YW for any W
    
    if X->Y then W,X->W,Y

### Axiom of transitivity
The axiom of transitivity says if X determines Y, and Y determines Z, then X must also determine Z 
    
    if X->Y and Y->Z then X->Z

### Union
This rule suggests that if two tables are separate, and the PK is the same, you may want to consider putting them together. It states that if X determines Y and X determines Z then X must also determine Y and Z
    
    if X->Y and X->Z then X->Y,Z

### Decomposition
Decomposition is the reverse of the Union rule. If you have a table that appears to contain two entities that are determined by the same PK, consider breaking them up into two tables. This rule states that if X determines Y and Z, then X determines Y and X determines Z separately
    
    if X->Y,Z then X->Y and X->Z

Check More on this site: https://opentextbc.ca/dbdesign01/chapter/chapter-11-functional-dependencies/