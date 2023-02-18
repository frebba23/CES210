class Customer {
  //Declare class variables
  private String name;
  private Address address;

  //Constructor
  public Customer(String name, Address address) {
    this.name = name;
    this.address = address;
  }

  //Methods
  public boolean isInUSA() {
    return address.isInUSA();
  }

  public String getName() {
    return this.name;
  }

  public Address getAddress() {
    return this.address;
  }
}