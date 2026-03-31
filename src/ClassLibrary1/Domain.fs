namespace ClassLIbrary1.Core

/// Represents a person in the family tree
type Person = {
    Id: string
    FirstName: string
    LastName: string
    BirthDate: System.DateTime option
    DeathDate: System.DateTime option
    Gender: Gender
    Biography: string option
}

/// Gender enumeration
and Gender = 
    | Male
    | Female
    | Unknown

/// Represents a relationship between two people
type Relationship = {
    Person1Id: string
    Person2Id: string
    RelationshipType: RelationshipType
}

/// Types of relationships
and RelationshipType =
    | ParentChild
    | Spouse
    | Sibling

/// The main family tree structure
type FamilyTree = {
    Id: string
    Name: string
    Description: string option
    People: Map<string, Person>
    Relationships: Relationship list
    CreatedDate: System.DateTime
    ModifiedDate: System.DateTime
}
