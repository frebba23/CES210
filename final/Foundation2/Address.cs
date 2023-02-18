class Address {
  //Declare class variables
  private String streetAddress;
  private String stateOrProvince;
  private String city;

  //Constructor
  public Address(String streetAddress, String stateOrProvince, String city) {
    this.streetAddress = streetAddress;
    this.stateOrProvince = stateOrProvince;
    this.city = city;
  }

  //Methods
  public boolean isInUSA() {
    if (stateOrProvince == "USA") {
      return true;
    } else {
      return false;
    }
  }

  public String getStreetAddress() {
    return this.streetAddress;
  }

  public String getStateOrProvince() {
    return this.stateOrProvince;
  }

  public String getCity() {
    return this.city;
  }
}
