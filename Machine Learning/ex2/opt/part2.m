
%Benchmark data is a 256x500x10 matrix
%feature is a matrix that is formed as a result of PartA 
%feature matrices are named: f1, f2, f3, f4, f5
%noOfExamples is the number of examples of a handwritten value.
%e.g.: for 100 examples of 3,6 and 8 you would write 100 from noOfExamples


function [test,testlabels] = part2(benchmarkdata, featureNo,noOfExamples)

feature = extractmyfeatures(getonedigit(1,1,benchmarkdata),featureNo);

noOfFeatures = size(feature,2);
test = zeros(noOfExamples*3, noOfFeatures);

random = randperm(500);
for i = 1:noOfExamples
    test(i,:) = extractmyfeatures(getonedigit(3, random(:,i), ...
                                                 benchmarkdata),featureNo);
    test(noOfExamples + i,:) = extractmyfeatures(getonedigit(6, ...
                               random(:,i), benchmarkdata),featureNo);
    test(2*noOfExamples + i,:) = extractmyfeatures(getonedigit(8, ...
                               random(:,i), benchmarkdata),featureNo);
end
testlabels = [repmat(3, noOfExamples, 1);repmat(6,noOfExamples,1); ...
              repmat(8,noOfExamples,1)];





