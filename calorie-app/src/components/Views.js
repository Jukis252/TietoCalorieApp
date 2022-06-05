// eslint-disable-next-line import/no-extraneous-dependencies
import './Views.css';
import Box from '@mui/material/Box';
import { Divider } from '@mui/material';
import { useState } from 'react';
import Heading2 from './Heading2/Heading2';
import FindFood from './FindFood/FindFood';
import DisplayTable from './DisplayTable/DisplayTable';

function Views() {
  const [name, setName] = useState('');

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
                label="Food name"
                placeholder="Enter food name"
                name={name}
                setName={setName}
              />
            </Box>
            <Divider />
          </div>
        </div>
        <div className="Display">
          Display
          <div className="DisplayBody">
            <Divider />
            <Box className="BoxStyles DisplayTable">
              <DisplayTable />
            </Box>
            This is display body

          </div>
        </div>
      </div>
    </div>
  );
}

export default Views;
