// eslint-disable-next-line import/no-extraneous-dependencies
import './Views.css';
import Box from '@mui/material/Box';
import { Divider } from '@mui/material';
import Heading2 from './Heading2/Heading2';
import FindFood from './FindFood/FindFood';

function Views() {
  return (
    <div className="page">
      <div className="header">Calorie App</div>
      <div className="body">
        <div className="Menu">
          Menu
          <div className="MenuBody">
            <Divider />
            <Box className="BoxStyles FindFood">
              <Heading2>Find Food</Heading2>
              <FindFood
                fullWidth
                label="Food name"
                placeholder="Enter food name"
              />
            </Box>
            <Divider />
          </div>
        </div>
        <div className="Display">
          This is display
          <div className="DisplayBody">This is display body</div>
        </div>
      </div>
    </div>
  );
}

export default Views;
