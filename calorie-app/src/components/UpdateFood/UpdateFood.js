import { Button, TextField } from '@mui/material';
import './UpdateFood.css';
import { useState } from 'react';
import FoodService from '../../services/FoodService';

const foodService = new FoodService();

function UpdateFood() {
  const [foodName, setFoodName] = useState('');
  const [calorieCount, setcalorieCount] = useState('');
  const [carbsCount, setcarbsCount] = useState('');
  const [proteinCount, setproteinCount] = useState('');
  const [fatsCount, setfatsCount] = useState('');
  const data = {
    name: foodName,
    calorieCount,
    carbsCount,
    proteinCount,
    fatsCount,
  };

  const handleNameChange = (event) => {
    setFoodName(event.target.value);
  };
  const handleCalorieChange = (event) => {
    setcalorieCount(event.target.value);
  };
  const handleCarbsChange = (event) => {
    setcarbsCount(event.target.value);
  };
  const handleProteinChange = (event) => {
    setproteinCount(event.target.value);
  };
  const handleFatsChange = (event) => {
    setfatsCount(event.target.value);
  };
  const UpdateFoodAsync = async () => {
    foodService
      .updateFood(data)
      .then((response) => {
        if (!response.ok) {
          throw Error('Could not POST the data to database, response not OK');
        }
      })
      .catch();
  };
  return (
    <div className="content">
      <div className="foodName">
        <TextField
          className="FoodName"
          label="Food name"
          onChange={handleNameChange}
          value={foodName}
        />
      </div>
      <div className="calorieCount">
        <TextField
          className="caloriecount"
          label="Calorie count"
          onChange={handleCalorieChange}
          value={calorieCount}
        />
      </div>
      <div className="carbsCount">
        <TextField
          className="carbscount"
          label="Carbs count"
          onChange={handleCarbsChange}
          value={carbsCount}
        />
      </div>
      <div className="proteinCount">
        <TextField
          className="proteincount"
          label="Protein count"
          onChange={handleProteinChange}
          value={proteinCount}
        />
      </div>
      <div className="fatsCount">
        <TextField
          className="fatscount"
          label="Fats count"
          onChange={handleFatsChange}
          value={fatsCount}
        />
      </div>
      <div className="postButton">
        <Button
          className="PostButton"
          variant="outlined"
          onClick={UpdateFoodAsync}
        >
          Update
        </Button>
      </div>
    </div>
  );
}

export default UpdateFood;
