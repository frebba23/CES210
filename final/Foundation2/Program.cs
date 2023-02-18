using System;

public class OnlineOrderingProgram {
  public static void main(String[] args) {
    //Create customers and addresses
    Address address1 = new Address("123 Main Street", "USA", "New York");
    Customer customer1 = new Customer("John Doe", address1);

    Address address2 = new Address("456 Main Street", "Canada", "Toronto");
    Customer customer2 = new Customer("Jane Doe", address2);

    //Create products
    Product product1 = new Product("Laptop", "123", 500.00, 1);
    Product product2 = new Product("Printer", "456", 200.00, 1);
    Product product3 = new Product("Mouse", "789", 50.00, 1);
    Product product4 = new Product("Monitor", "098", 300.00, 1);

    //Create orders
    Product[] products1 = {product1, product2};
    Order order1 = new Order(customer1, products1);

    Product[] products2 = {product3, product4};
    Order order2 = new Order(customer2, products2);

    //Call methods to get packing label, shipping label, total order price, and display the results of these methods
    System.out.println("Order 1 Packing Label:");
    System.out.println(order1.getPackingLabel());
    System.out.println("Order 1 Shipping Label:");
    System.out.println(order1.getShippingLabel());
    System.out.println("Order 1 Total Price: $" + order1.getTotalPrice());
    System.out.println();

    System.out.println("Order 2 Packing Label:");
    System.out.println(order2.getPackingLabel());
    System.out.println("Order 2 Shipping Label:");
    System.out.println(order2.getShippingLabel());
    System.out.println("Order 2 Total Price: $" + order2.getTotalPrice());
    System.out.println();
  }
}