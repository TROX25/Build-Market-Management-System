using System.ComponentModel.DataAnnotations;
using Build_Market_Management_System.Models;
using UseCases.Interfaces;

namespace Build_Market_Management_System.ViewModels.Validation
{
    public class SalesViewModel_EnsureProperQuantity : ValidationAttribute
    {
        // Klasa bazowa ValidationResult jest protected virtual, więc możemy ją nadpisać (wynika to z virtual)
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var salesViewModel = validationContext.ObjectInstance as SalesViewModel;

            if (salesViewModel != null)
            {
                // Sprawdzamy, czy QuantityToSell jest większe niż 0
                if (salesViewModel.QuantityToSell <= 0)
                {
                    return new ValidationResult("Quantity to sell must be greater than zero.");
                }
                else
                {
                    // Inne Dependency Injection nie działa w atrybutach, więc musimy uzyskać dostęp do repozytorium w inny sposób
                    var getProductByIdUseCase = validationContext.GetService(typeof(IViewSelectedProductUseCase)) as IViewSelectedProductUseCase;

                    if (getProductByIdUseCase != null)
                    {
                        var product = getProductByIdUseCase.Execute(salesViewModel.SelectedProductId);

                        if (product != null)
                        {
                            if (product.Quantity < salesViewModel.QuantityToSell)
                            {
                                return new ValidationResult($"Insufficient stock. Available quantity: {product.Quantity.Value}.");
                            }
                        
                        }
                        else
                        {
                            return new ValidationResult("Selected product doesn't exist.");
                        }
                    }
                }

            }
            else
            {
                return new ValidationResult("Invalid sales data.");
            }
            return ValidationResult.Success;


        }
    }
}
