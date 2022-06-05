import { useEffect, useState } from 'react';
import Table from '@mui/material/Table';
import TableBody from '@mui/material/TableBody';
import TableCell from '@mui/material/TableCell';
import TableContainer from '@mui/material/TableContainer';
import TableHead from '@mui/material/TableHead';
import TableRow from '@mui/material/TableRow';
import Paper from '@mui/material/Paper';
import FoodService from '../../services/FoodService';

const foodService = new FoodService();

// function createData(name, calories, fat, carbs, protein) {
//   return {
//     name, calories, fat, carbs, protein,
//   };
// }

function DisplayTable() {
  const [food, setFood] = useState();

  useEffect(() => {
    foodService
      .getAll()
      .then((res) => {
        if (!res.ok) {
          throw Error('could not fetch the data for that resource');
        }
        return res.json();
      })
      .then((dataFromDB) => {
        setFood(dataFromDB);
      });
  }, []);

  return (
    <TableContainer component={Paper}>
      <Table sx={{ minWidth: 650 }} aria-label="simple table">
        <TableHead>
          <TableRow>
            <TableCell>Food (100g serving)</TableCell>
            <TableCell align="right">Calories</TableCell>
            <TableCell align="right">Fat&nbsp;(g)</TableCell>
            <TableCell align="right">Carbs&nbsp;(g)</TableCell>
            <TableCell align="right">Protein&nbsp;(g)</TableCell>
          </TableRow>
        </TableHead>
        <TableBody>
          {food && food.map((foods) => (
            <TableRow
              key={foods.id}
              value={foods.id}
            >
              <TableCell component="th" scope="row">
                {foods.name}
              </TableCell>
              <TableCell align="right">{foods.calorieCount}</TableCell>
              <TableCell align="right">{foods.fatsCount}</TableCell>
              <TableCell align="right">{foods.carbsCount}</TableCell>
              <TableCell align="right">{foods.proteinCount}</TableCell>
            </TableRow>
          ))}
        </TableBody>
      </Table>
    </TableContainer>
  );
}

export default DisplayTable;
