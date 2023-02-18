class Product {
  //Declare class variables
  private String name;
  private String id;
  private double price;
  private int quantity;

  //Constructor
  public Product(String name, String id, double price, int quantity) {
    this.name = name;
    this.id = id;
    this.price = price;
    this.quantity = quantity;
  }

  //Methods
  public double getPrice() {
    return this.price * this.quantity;
  }

  public String getName() {
    return this.name;
  }

  public String getId() {
    return this.id;
  }
}
