%first matrix gets 100 random samples of 3
%second matrix gets 200 random samples of 8
%firstT is the first matrix tranposed
%secondT is the second matrix transposed
%trainingset is vertical concatination of the two transposed matrices

%test: [trainingset,labels] = maketrainingset(maindata)
%reshape(trainingset(1, :), 16,16) this gets the first row/sample and 
%transforms the 1 by 256 matrix to a 16 by 16 matrix
%labels(101, :) or labels([1,101], :)




function [trainingset,truelabels] = partA2(data, noOfExamples)

first = data(: , randperm(500,noOfExamples), 3);
second = data(:, randperm(500,noOfExamples), 6);
third = data(:, randperm(500,noOfExamples), 8);
firstT = first';
secondT = second';
thirdT = third';
trainingset = [firstT;secondT;thirdT];
truelabels = [repmat(3, noOfExamples, 1);repmat(6,noOfExamples,1); ...
              repmat(8,noOfExamples,1)];


