function sampledata = generaldata(digit1, digit2, data)
first = data(:, randi(500,100,1), digit1);
second = data(:, randi(500,100,1), digit2);
firstT = first';
secondT = second';
sampledata = [firstT;secondT];

