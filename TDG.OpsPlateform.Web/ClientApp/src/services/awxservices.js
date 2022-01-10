const axios = require('axios');

async function makeGetRequest() {

    let res = await axios.get('/AWXJobs');

  let data = res.data;
  console.log(data);
}