function [dataArray,dataLabels] = part2A(data, noOfExamples, valuesArray)

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
%dataArray = [firstT;secondT;thirdT];
%datalabels = [repmat(3, noOfExamples, 1);repmat(6,noOfExamples,1); ...
%              repmat(8,noOfExamples,1)];





