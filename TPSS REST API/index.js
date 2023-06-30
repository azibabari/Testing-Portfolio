const express = require ('express');
const bodyParser = require ('body-parser');
const cors = require ('cors');
const helmet = require ('helmet');
const morgan = require ('morgan');
const app = express ();
const port = 3000;
const ads = [
		{title: 'TPSS APP (again)!'}
];
app.use(helmet());
app.use(bodyParser.json());
app.use(cors());
app.use(morgan('combined'));
app.get('/',(req, res) => {
	res.send(ads);
});
app.listen (3000, () => {
	console.log('listening on port 3000')
});