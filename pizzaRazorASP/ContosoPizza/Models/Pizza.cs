using System.ComponentModel.DataAnnotations;
// This line includes the necessary namespace for working with data annotations, which are used to specify constraints and validation rules for model properties.

namespace ContosoPizza.Models;
// This declares a namespace for your models. It's good practice to organize ur classes into namespaces to avoid naming conflicts.


public class Pizza  // This is the class definition for a Pizza. It represents a pizza entity with various properties.
{
    public int Id { get; set; } // This is a property named "Id" of type integer. It likely represents the unique identifier for each pizza.

    [Required] // for "name" property data annotation. NON-NULLING, the name must have value/cannot-be-empty. The "name" property should not be left blank.
    public string? Name { get; set; } // property: "name". type: string. the question mark is a modifier. it can have a value of null. [Required] overrides the string? modifier.
    public PizzaSize Size { get; set; } // property: "Size" type: "PizzaSize/enum" 
    public bool IsGlutenFree { get; set; } // property: "IsGlutenFree" type: boolean. whether the pizza will be gluten free or not. 

    [Range(0.01, 9999.99)]  // data annotation attribute attributed to the "Price" property. It specifies that price must have a value within the specified range.
    public decimal Price { get; set; } // property: "Price" type: decimal. constrianed by range to be a number that falls between that specification.
}

public enum PizzaSize { Small, Medium, Large }