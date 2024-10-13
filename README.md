# Functional Dependencies

A functional dependency (FD) is a relationship between two attributes, typically between the PK and other non-key attributes within a table. For any relation R, attribute Y is functionally dependent on attribute X (usually the PK), if for every valid instance of X, that value of X uniquely determines the value of Y. This relationship is indicated by the representation below:

        **X-->Y**

For examples:
        **StudentID-->StudentName**
        **ISBN-->Title**

## Inference Rules
Armstrong’s axioms are a set of inference rules used to infer all the functional dependencies on a relational database. They were developed by William W. Armstrong. The following describes what will be used, in terms of notation, to explain these axioms.

Let R(U) be a relation scheme over the set of attributes U. We will use the letters X, Y, Z to represent any subset of and, for short, the union of two sets of attributes, instead of the usual  X U Y.

### Axiom of reflexivity
This axiom says, if Y is a subset of X, then X determines Y

        \[
        X \subseteq Y
        \]