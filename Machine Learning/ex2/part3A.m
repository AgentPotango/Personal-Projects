function [dataArray,dataLabels] = part3A(data, noOfExamples,valuesArray)

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
