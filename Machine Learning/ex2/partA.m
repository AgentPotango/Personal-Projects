%first matrix gets 100 random samples of 3
%second matrix gets 200 random samples of 8
%firstT is the first matrix tranposed
%secondT is the second matrix transposed
%trainingset is vertical concatination of the two transposed matrices

%test: [trainingset,labels] = maketrainingset(maindata)
%reshape(trainingset(1, :), 16,16) this gets the first row/sample and 
%transforms the 1 by 256 matrix to a 16 by 16 matrix
%labels(101, :) or labels([1,101], :)




function [dataArray,dataLabels] = partA(data, noOfExamples,valuesArray)

noOfValues = size(valuesArray,1);
noOfData = noOfExamples * noOfValues;


dataArray = zeros(noOfData,256);
dataLabels = zeros(noOfData,1);
value = zeros(noOfValues);
startIndex = 1;
endIndex = noOfExamples;

for i = 1:noOfValues
    value(i) = valuesArray(i,1);
    set = data(: , randperm(500,noOfExamples), value(i));
    dataArray(startIndex:endIndex,:) = set';
    dataLabels(startIndex:endIndex,:) = value(i);
    startIndex = startIndex + noOfExamples;
    endIndex = endIndex + noOfExamples;
end
%first = data(: , randperm(500,noOfExamples), 3);
%second = data(:, randperm(500,noOfExamples), 6);
%third = data(:, randperm(500,noOfExamples), 8);
%firstT = first';
%secondT = second';
%thirdT = third';
%trainingset = [firstT;secondT;thirdT];
%truelabels = [repmat(3, noOfExamples, 1);repmat(6,noOfExamples,1); ...
%              repmat(8,noOfExamples,1)];


