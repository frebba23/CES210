class Order {
  //Declare class variables
  private Customer customer;
  private Product[] products;
  private double totalPrice;

  //Constructor
  public Order(Customer customer, Product[] products) {
    this.customer = customer;
    this.products = products;
  }

  //Methods
  public double getTotalPrice() {
    double sum = 0.0;
    for (Product product : products) {
      sum += product.getPrice();
    }
    if (customer.getAddress().isInUSA()) {
      sum += 5.0;
    } else {
      sum += 35.0;
    }
    this.totalPrice = sum;
    return this.totalPrice;
  }

  public String getPackingLabel() {
    String label = "";
    for (Product product : products) {
      label += product.getName() + " (" + product.getId() + ")\n";
    }
    return label;
  }

  public String getShippingLabel() {
    return customer.getName() + "\n" + customer.getAddress().getStreetAddress() + "\n" + customer.getAddress().getStateOrProvince() + "\n" + customer.getAddress().getCity();
  }
}