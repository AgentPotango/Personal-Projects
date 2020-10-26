function part1(maindata)
[training, labels] = partA(maindata);
pause;
partB(training, training, labels, labels);
pause;
[accuracy] = partC(training, labels);
pause;
partD(training, labels, accuracy);
