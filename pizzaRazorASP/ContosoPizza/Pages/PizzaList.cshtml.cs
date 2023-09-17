using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using ContosoPizza.Models;
using ContosoPizza.Services;

namespace ContosoPizza.Pages


{
    private readonly PizzaService _service;
    public IList<Pizza> PizzaList { get;set; } = default!;

    public PizzaListModel(PizzaService service)
    {
        _service = service;
    }

    public void OnGet()
    {
        PizzaList = _service.GetPizzas();
    }



}

/*
A private readonly PizzaService named _service is created. This variable will hold a reference to a PizzaService object.
The readonly keyword indicates that the value of the _service variable can't be changed after it's set in the constructor.
A PizzaList property is defined to hold the list of pizzas.
The IList<Pizza> type indicates that the PizzaList property will hold a list of Pizza objects.
PizzaList is initialized to default! to indicate to the compiler that it will be initialized later, so null safety checks aren't required.
The constructor accepts a PizzaService object.
The PizzaService object is provided by dependency injection.
An OnGet method is defined to retrieve the list of pizzas from the PizzaService object and store it in the PizzaList property.
*/

