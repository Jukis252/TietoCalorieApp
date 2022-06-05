const headers = {
  Accept: 'application/json',
  'Content-type': 'application/json',
};

// eslint-disable-next-line no-unused-vars
class FoodService {
  constructor() {
    this.url = 'https://localhost:7049/Dish';
  }

  getAll() {
    const method = 'GET';
    const options = {
      headers,
      method,
    };
    return fetch(this.url, options);
  }
}
export default FoodService;
