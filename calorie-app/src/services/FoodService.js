const headers = {
  Accept: 'application/json',
  'Content-type': 'application/json',
};

// eslint-disable-next-line no-unused-vars
class FoodService {
  constructor() {
    this.url = 'https://localhost:7049/Food';
  }

  getAll() {
    const method = 'GET';
    const options = {
      headers,
      method,
    };
    return fetch(this.url, options);
  }

  addFood(data) {
    const method = 'POST';
    const options = {
      headers,
      method,
    };
    if (data) {
      options.body = JSON.stringify(data);
    }
    return fetch(this.url, options);
  }

  updateFood(data) {
    const method = 'PUT';
    const options = {
      headers,
      method,
    };
    if (data) {
      options.body = JSON.stringify(data);
    }
    return fetch(this.url, options);
  }
}
export default FoodService;
