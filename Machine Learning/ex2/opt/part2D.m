function [test,testlabels] = part2D(benchmarkdata, noOfExamples)

%[f1,f2,f3,f4,f5] = extractmyfeatures(getonedigit(1,1,benchmarkdata));

l=zeros(noOfExamples,128);
random = randperm(500);
for i = 1:noOfExamples
    [~,k,~,~,~] = extractmyfeatures(getonedigit(1,random(:,i),benchmarkdata));
    l(i,:) = k;
end
testlabels = [repmat(3, noOfExamples, 1);repmat(6,noOfExamples,1); ...
              repmat(8,noOfExamples,1)];
